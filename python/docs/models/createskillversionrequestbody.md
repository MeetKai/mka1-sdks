# CreateSkillVersionRequestBody


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `files`                                                                    | List[[models.CreateSkillVersionFile](../models/createskillversionfile.md)] | :heavy_minus_sign:                                                         | Skill version files to upload (must include SKILL.md)                      |
| `default`                                                                  | *Optional[bool]*                                                           | :heavy_minus_sign:                                                         | Set this version as the default                                            |