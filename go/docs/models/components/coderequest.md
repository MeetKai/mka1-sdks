# CodeRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `SessionID`                                                       | `string`                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `SessionToken`                                                    | optionalnullable.OptionalNullable[`string`]                       | :heavy_minus_sign:                                                | N/A                                                               |
| `Runtime`                                                         | [*components.CodeRuntime](../../models/components/coderuntime.md) | :heavy_minus_sign:                                                | N/A                                                               |
| `Code`                                                            | `string`                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `Cwd`                                                             | optionalnullable.OptionalNullable[`string`]                       | :heavy_minus_sign:                                                | N/A                                                               |
| `Env`                                                             | map[string]`string`                                               | :heavy_minus_sign:                                                | N/A                                                               |
| `TimeoutSeconds`                                                  | `*int64`                                                          | :heavy_minus_sign:                                                | N/A                                                               |