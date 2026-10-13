# CreatePromptRequest


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `name`                                                  | *str*                                                   | :heavy_check_mark:                                      | Human-readable prompt name                              |
| `description`                                           | *Optional[str]*                                         | :heavy_minus_sign:                                      | Detailed description of the prompt                      |
| `template`                                              | *str*                                                   | :heavy_check_mark:                                      | The prompt template text with {{variable}} placeholders |
| `metadata`                                              | Dict[str, *Any*]                                        | :heavy_minus_sign:                                      | Custom metadata key-value pairs                         |