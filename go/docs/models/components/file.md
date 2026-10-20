# File


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ID`                                                            | `string`                                                        | :heavy_check_mark:                                              | The file identifier                                             |
| `Object`                                                        | `*string`                                                       | :heavy_minus_sign:                                              | N/A                                                             |
| `Bytes`                                                         | `int64`                                                         | :heavy_check_mark:                                              | The size of the file in bytes                                   |
| `CreatedAt`                                                     | `int64`                                                         | :heavy_check_mark:                                              | Unix timestamp when the file was created                        |
| `ExpiresAt`                                                     | optionalnullable.OptionalNullable[`int64`]                      | :heavy_minus_sign:                                              | Unix timestamp when the file expires                            |
| `Filename`                                                      | `string`                                                        | :heavy_check_mark:                                              | The name of the file                                            |
| `Purpose`                                                       | [components.Purpose](../../models/components/purpose.md)        | :heavy_check_mark:                                              | The intended purpose of the file                                |
| `Status`                                                        | [*components.FileStatus](../../models/components/filestatus.md) | :heavy_minus_sign:                                              | DEPRECATED: File processing status                              |
| `StatusDetails`                                                 | `*string`                                                       | :heavy_minus_sign:                                              | DEPRECATED: Details about file status                           |