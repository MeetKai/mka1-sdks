# CodeRequest


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `SessionId`                                          | *string*                                             | :heavy_check_mark:                                   | N/A                                                  |
| `SessionToken`                                       | *string*                                             | :heavy_minus_sign:                                   | N/A                                                  |
| `Runtime`                                            | [CodeRuntime](../../Types/Components/CodeRuntime.md) | :heavy_minus_sign:                                   | N/A                                                  |
| `Code`                                               | *string*                                             | :heavy_check_mark:                                   | N/A                                                  |
| `Cwd`                                                | *string*                                             | :heavy_minus_sign:                                   | N/A                                                  |
| `Env`                                                | Dictionary<String, *string*>                         | :heavy_minus_sign:                                   | N/A                                                  |
| `TimeoutSeconds`                                     | *long*                                               | :heavy_minus_sign:                                   | N/A                                                  |