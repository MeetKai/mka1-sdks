# SchemaCreateResponse

Response from creating a new extraction schema.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Success`                                                                                  | `bool`                                                                                     | :heavy_check_mark:                                                                         | Indicates whether the schema creation was successful                                       |
| `Data`                                                                                     | [components.SchemaCreateResponseData](../../models/components/schemacreateresponsedata.md) | :heavy_check_mark:                                                                         | The created extraction schema with generated ID and timestamps                             |