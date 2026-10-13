# File


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `id`                                                   | *str*                                                  | :heavy_check_mark:                                     | The file identifier                                    |
| `object`                                               | *Optional[Literal["file"]]*                            | :heavy_minus_sign:                                     | N/A                                                    |
| `bytes_`                                               | *int*                                                  | :heavy_check_mark:                                     | The size of the file in bytes                          |
| `created_at`                                           | *int*                                                  | :heavy_check_mark:                                     | Unix timestamp when the file was created               |
| `expires_at`                                           | *OptionalNullable[int]*                                | :heavy_minus_sign:                                     | Unix timestamp when the file expires                   |
| `filename`                                             | *str*                                                  | :heavy_check_mark:                                     | The name of the file                                   |
| `purpose`                                              | [models.Purpose](../models/purpose.md)                 | :heavy_check_mark:                                     | The intended purpose of the file                       |
| `status`                                               | [Optional[models.FileStatus]](../models/filestatus.md) | :heavy_minus_sign:                                     | DEPRECATED: File processing status                     |
| `status_details`                                       | *Optional[str]*                                        | :heavy_minus_sign:                                     | DEPRECATED: Details about file status                  |