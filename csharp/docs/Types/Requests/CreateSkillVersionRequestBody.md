# CreateSkillVersionRequestBody


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Files`                                                                        | List<[CreateSkillVersionFile](../../Types/Requests/CreateSkillVersionFile.md)> | :heavy_minus_sign:                                                             | Skill version files to upload (must include SKILL.md)                          |
| `Default`                                                                      | *bool*                                                                         | :heavy_minus_sign:                                                             | Set this version as the default                                                |