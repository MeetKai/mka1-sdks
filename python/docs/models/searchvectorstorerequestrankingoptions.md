# SearchVectorStoreRequestRankingOptions

Ranking options for search.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `ranker`                                                                    | [Optional[models.Ranker]](../models/ranker.md)                              | :heavy_minus_sign:                                                          | Enable re-ranking; set to 'none' to disable, which can help reduce latency. |
| `score_threshold`                                                           | *Optional[float]*                                                           | :heavy_minus_sign:                                                          | Minimum score threshold for search results.                                 |