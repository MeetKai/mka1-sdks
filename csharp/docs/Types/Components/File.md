# File


## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `Id`                                               | *string*                                           | :heavy_check_mark:                                 | The file identifier                                |
| `Object`                                           | *string*                                           | :heavy_minus_sign:                                 | N/A                                                |
| `Bytes`                                            | *long*                                             | :heavy_check_mark:                                 | The size of the file in bytes                      |
| `CreatedAt`                                        | *long*                                             | :heavy_check_mark:                                 | Unix timestamp when the file was created           |
| `ExpiresAt`                                        | *long*                                             | :heavy_minus_sign:                                 | Unix timestamp when the file expires               |
| `Filename`                                         | *string*                                           | :heavy_check_mark:                                 | The name of the file                               |
| `Purpose`                                          | [Purpose](../../Types/Components/Purpose.md)       | :heavy_check_mark:                                 | The intended purpose of the file                   |
| `Status`                                           | [FileStatus](../../Types/Components/FileStatus.md) | :heavy_minus_sign:                                 | DEPRECATED: File processing status                 |
| `StatusDetails`                                    | *string*                                           | :heavy_minus_sign:                                 | DEPRECATED: Details about file status              |