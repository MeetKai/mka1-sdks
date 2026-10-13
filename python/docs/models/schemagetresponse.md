# SchemaGetResponse

Response from retrieving an extraction schema by ID.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `success`                                                          | *bool*                                                             | :heavy_check_mark:                                                 | Indicates whether the schema retrieval was successful              |
| `data`                                                             | [models.SchemaGetResponseData](../models/schemagetresponsedata.md) | :heavy_check_mark:                                                 | The requested extraction schema                                    |