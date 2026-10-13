# CreatePromptResponseVersion

The initial version created with this prompt


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `id`                                                                 | *str*                                                                | :heavy_check_mark:                                                   | Unique version identifier                                            |
| `prompt_id`                                                          | *str*                                                                | :heavy_check_mark:                                                   | Parent prompt identifier                                             |
| `version`                                                            | *int*                                                                | :heavy_check_mark:                                                   | Version number                                                       |
| `object`                                                             | *Literal["prompt.version"]*                                          | :heavy_check_mark:                                                   | Object type                                                          |
| `template`                                                           | *str*                                                                | :heavy_check_mark:                                                   | The prompt template text with {{variable}} placeholders              |
| `created_at`                                                         | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_check_mark:                                                   | Timestamp when this version was created                              |