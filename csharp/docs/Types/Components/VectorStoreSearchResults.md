# VectorStoreSearchResults

A page of search results from the vector store.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Object`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | The object type, which is always 'vector_store.search_results.page'.     |
| `SearchQuery`                                                            | *string*                                                                 | :heavy_check_mark:                                                       | The query that was used for the search.                                  |
| `Data`                                                                   | List<[VectorSearchResult](../../Types/Components/VectorSearchResult.md)> | :heavy_check_mark:                                                       | Array of search results.                                                 |
| `HasMore`                                                                | *bool*                                                                   | :heavy_check_mark:                                                       | Whether there are more results available.                                |
| `NextPage`                                                               | *string*                                                                 | :heavy_check_mark:                                                       | Cursor for the next page of results, or null if no more results.         |