# ComputeSecret


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `CreatedAt`                                                       | [time.Time](https://pkg.go.dev/time#Time)                         | :heavy_check_mark:                                                | N/A                                                               |
| `ExpiresAt`                                                       | [*time.Time](https://pkg.go.dev/time#Time)                        | :heavy_check_mark:                                                | When the secret stops resolving for new launches; null for never. |
| `ID`                                                              | `string`                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `Keys`                                                            | []`string`                                                        | :heavy_check_mark:                                                | N/A                                                               |
| `Name`                                                            | `string`                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `UpdatedAt`                                                       | [time.Time](https://pkg.go.dev/time#Time)                         | :heavy_check_mark:                                                | When the current version was written.                             |
| `Version`                                                         | `int64`                                                           | :heavy_check_mark:                                                | Starts at 1 and increments on every rotation.                     |