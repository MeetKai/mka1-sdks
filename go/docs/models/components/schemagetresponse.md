# SchemaGetResponse

Response from retrieving an extraction schema by ID.


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Success`                                                                            | `bool`                                                                               | :heavy_check_mark:                                                                   | Indicates whether the schema retrieval was successful                                |
| `Data`                                                                               | [components.SchemaGetResponseData](../../models/components/schemagetresponsedata.md) | :heavy_check_mark:                                                                   | The requested extraction schema                                                      |