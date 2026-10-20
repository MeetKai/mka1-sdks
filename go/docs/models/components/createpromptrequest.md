# CreatePromptRequest


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Name`                                                  | `string`                                                | :heavy_check_mark:                                      | Human-readable prompt name                              |
| `Description`                                           | `*string`                                               | :heavy_minus_sign:                                      | Detailed description of the prompt                      |
| `Template`                                              | `string`                                                | :heavy_check_mark:                                      | The prompt template text with {{variable}} placeholders |
| `Metadata`                                              | map[string]`any`                                        | :heavy_minus_sign:                                      | Custom metadata key-value pairs                         |