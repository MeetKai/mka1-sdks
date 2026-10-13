# SchemaCreateResponseData

The created extraction schema with generated ID and timestamps


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `id`                                                                 | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the extraction schema                          |
| `name`                                                               | *str*                                                                | :heavy_check_mark:                                                   | Name of the extraction schema                                        |
| `description`                                                        | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional description of the schema                                   |
| `schema_`                                                            | Dict[str, *Any*]                                                     | :heavy_check_mark:                                                   | The JSON Schema object defining the extraction structure             |
| `metadata`                                                           | Dict[str, *Any*]                                                     | :heavy_minus_sign:                                                   | Optional metadata associated with the schema                         |
| `created_at`                                                         | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_check_mark:                                                   | ISO 8601 timestamp when the schema was created                       |
| `updated_at`                                                         | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_check_mark:                                                   | ISO 8601 timestamp when the schema was last updated                  |