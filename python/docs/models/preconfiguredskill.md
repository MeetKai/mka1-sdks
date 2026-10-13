# PreconfiguredSkill


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `name`                                                                         | *str*                                                                          | :heavy_check_mark:                                                             | Skill name, used as { type: 'preconfigured', name: '...' } in tool definitions |
| `description`                                                                  | *str*                                                                          | :heavy_check_mark:                                                             | Description of what the skill does                                             |
| `object`                                                                       | *Optional[Literal["preconfigured_skill"]]*                                     | :heavy_minus_sign:                                                             | N/A                                                                            |