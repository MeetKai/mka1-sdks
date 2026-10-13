# UpdatePromptRequestBody


## Fields

| Field                                    | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `name`                                   | *Optional[str]*                          | :heavy_minus_sign:                       | Updated prompt name                      |
| `description`                            | *OptionalNullable[str]*                  | :heavy_minus_sign:                       | Updated description — pass null to clear |
| `metadata`                               | Dict[str, *Any*]                         | :heavy_minus_sign:                       | Updated metadata — replaces existing     |