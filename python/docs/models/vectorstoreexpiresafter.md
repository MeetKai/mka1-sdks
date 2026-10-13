# VectorStoreExpiresAfter

The expiration policy for a vector store.


## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `anchor`                                                                                               | *Literal["last_active_at"]*                                                                            | :heavy_check_mark:                                                                                     | Anchor timestamp after which the expiration policy applies. Supported anchors: last_active_at.         |
| `days`                                                                                                 | *int*                                                                                                  | :heavy_check_mark:                                                                                     | The number of days after the anchor time that the vector store will expire. Must be between 1 and 365. |