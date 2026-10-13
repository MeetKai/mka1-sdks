# SchemaUpdateResponse

Response from updating an existing extraction schema.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `success`                                                                | *bool*                                                                   | :heavy_check_mark:                                                       | Indicates whether the schema update was successful                       |
| `data`                                                                   | [models.SchemaUpdateResponseData](../models/schemaupdateresponsedata.md) | :heavy_check_mark:                                                       | The updated extraction schema with new updated_at timestamp              |