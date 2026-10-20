# SkillVersion


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ID`                                        | `string`                                    | :heavy_check_mark:                          | Unique identifier for the version           |
| `CreatedAt`                                 | `int64`                                     | :heavy_check_mark:                          | Unix timestamp when the version was created |
| `Description`                               | `string`                                    | :heavy_check_mark:                          | Description of the skill version            |
| `Name`                                      | `string`                                    | :heavy_check_mark:                          | Name of the skill version                   |
| `Object`                                    | `*string`                                   | :heavy_minus_sign:                          | N/A                                         |
| `SkillID`                                   | `string`                                    | :heavy_check_mark:                          | Parent skill identifier                     |
| `Version`                                   | `string`                                    | :heavy_check_mark:                          | Version number                              |