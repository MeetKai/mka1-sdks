# SchemaCreateResponse

Response from creating a new extraction schema.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `success`                                                                | *bool*                                                                   | :heavy_check_mark:                                                       | Indicates whether the schema creation was successful                     |
| `data`                                                                   | [models.SchemaCreateResponseData](../models/schemacreateresponsedata.md) | :heavy_check_mark:                                                       | The created extraction schema with generated ID and timestamps           |