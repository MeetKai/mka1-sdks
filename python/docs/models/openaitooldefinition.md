# OpenAIToolDefinition

A tool the model may call while generating a response.


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | *Literal["function"]*                                                            | :heavy_check_mark:                                                               | The type of the tool. Currently only 'function' is supported.                    |
| `function`                                                                       | [models.OpenAIToolDefinitionFunction](../models/openaitooldefinitionfunction.md) | :heavy_check_mark:                                                               | The function definition                                                          |