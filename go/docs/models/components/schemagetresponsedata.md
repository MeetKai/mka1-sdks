# SchemaGetResponseData

The requested extraction schema


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ID`                                                     | `string`                                                 | :heavy_check_mark:                                       | Unique identifier for the extraction schema              |
| `Name`                                                   | `string`                                                 | :heavy_check_mark:                                       | Name of the extraction schema                            |
| `Description`                                            | `*string`                                                | :heavy_minus_sign:                                       | Optional description of the schema                       |
| `Schema`                                                 | map[string]`any`                                         | :heavy_check_mark:                                       | The JSON Schema object defining the extraction structure |
| `Metadata`                                               | map[string]`any`                                         | :heavy_minus_sign:                                       | Optional metadata associated with the schema             |
| `CreatedAt`                                              | [time.Time](https://pkg.go.dev/time#Time)                | :heavy_check_mark:                                       | ISO 8601 timestamp when the schema was created           |
| `UpdatedAt`                                              | [time.Time](https://pkg.go.dev/time#Time)                | :heavy_check_mark:                                       | ISO 8601 timestamp when the schema was last updated      |