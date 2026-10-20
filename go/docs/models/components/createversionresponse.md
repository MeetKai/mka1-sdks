# CreateVersionResponse


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ID`                                                    | `string`                                                | :heavy_check_mark:                                      | Unique version identifier                               |
| `PromptID`                                              | `string`                                                | :heavy_check_mark:                                      | Parent prompt identifier                                |
| `Version`                                               | `int64`                                                 | :heavy_check_mark:                                      | Version number                                          |
| `Object`                                                | `string`                                                | :heavy_check_mark:                                      | Object type                                             |
| `Template`                                              | `string`                                                | :heavy_check_mark:                                      | The prompt template text with {{variable}} placeholders |
| `CreatedAt`                                             | [time.Time](https://pkg.go.dev/time#Time)               | :heavy_check_mark:                                      | Timestamp when this version was created                 |