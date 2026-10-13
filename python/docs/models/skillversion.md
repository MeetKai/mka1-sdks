# SkillVersion


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `id`                                        | *str*                                       | :heavy_check_mark:                          | Unique identifier for the version           |
| `created_at`                                | *int*                                       | :heavy_check_mark:                          | Unix timestamp when the version was created |
| `description`                               | *str*                                       | :heavy_check_mark:                          | Description of the skill version            |
| `name`                                      | *str*                                       | :heavy_check_mark:                          | Name of the skill version                   |
| `object`                                    | *Optional[Literal["skill.version"]]*        | :heavy_minus_sign:                          | N/A                                         |
| `skill_id`                                  | *str*                                       | :heavy_check_mark:                          | Parent skill identifier                     |
| `version`                                   | *str*                                       | :heavy_check_mark:                          | Version number                              |