# VectorStoreSearchResults

A page of search results from the vector store.


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `object`                                                             | *Literal["vector_store.search_results.page"]*                        | :heavy_check_mark:                                                   | The object type, which is always 'vector_store.search_results.page'. |
| `search_query`                                                       | *str*                                                                | :heavy_check_mark:                                                   | The query that was used for the search.                              |
| `data`                                                               | List[[models.VectorSearchResult](../models/vectorsearchresult.md)]   | :heavy_check_mark:                                                   | Array of search results.                                             |
| `has_more`                                                           | *bool*                                                               | :heavy_check_mark:                                                   | Whether there are more results available.                            |
| `next_page`                                                          | *Nullable[str]*                                                      | :heavy_check_mark:                                                   | Cursor for the next page of results, or null if no more results.     |