# SchemaUpdateResponse

Response from updating an existing extraction schema.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Success`                                                                                  | `bool`                                                                                     | :heavy_check_mark:                                                                         | Indicates whether the schema update was successful                                         |
| `Data`                                                                                     | [components.SchemaUpdateResponseData](../../models/components/schemaupdateresponsedata.md) | :heavy_check_mark:                                                                         | The updated extraction schema with new updated_at timestamp                                |