# SearchVectorStoreRequestRankingOptions

Ranking options for search.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Ranker`                                                                    | [Ranker](../../Types/Components/Ranker.md)                                  | :heavy_minus_sign:                                                          | Enable re-ranking; set to 'none' to disable, which can help reduce latency. |
| `ScoreThreshold`                                                            | *double*                                                                    | :heavy_minus_sign:                                                          | Minimum score threshold for search results.                                 |