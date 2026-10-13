# VectorStoreSearchResults

A page of search results from the vector store.

## Example Usage

```typescript
import { VectorStoreSearchResults } from "@meetkai/mka1/models/components";

let value: VectorStoreSearchResults = {
  object: "vector_store.search_results.page",
  searchQuery: "How do I reset my password?",
  data: [
    {
      fileId: "file-abc123",
      filename: "user-guide.pdf",
      score: 0.92,
      content: [
        {
          type: "text",
          text:
            "To reset your password, navigate to Settings > Security > Reset Password...",
        },
      ],
    },
  ],
  hasMore: false,
  nextPage: null,
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `object`                                                                         | *"vector_store.search_results.page"*                                             | :heavy_check_mark:                                                               | The object type, which is always 'vector_store.search_results.page'.             |
| `searchQuery`                                                                    | *string*                                                                         | :heavy_check_mark:                                                               | The query that was used for the search.                                          |
| `data`                                                                           | [components.VectorSearchResult](../../models/components/vectorsearchresult.md)[] | :heavy_check_mark:                                                               | Array of search results.                                                         |
| `hasMore`                                                                        | *boolean*                                                                        | :heavy_check_mark:                                                               | Whether there are more results available.                                        |
| `nextPage`                                                                       | *string*                                                                         | :heavy_check_mark:                                                               | Cursor for the next page of results, or null if no more results.                 |