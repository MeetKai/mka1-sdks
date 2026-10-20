# OpenAIToolDefinition

A tool the model may call while generating a response.


## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Type`                                                                                             | `string`                                                                                           | :heavy_check_mark:                                                                                 | The type of the tool. Currently only 'function' is supported.                                      |
| `Function`                                                                                         | [components.OpenAIToolDefinitionFunction](../../models/components/openaitooldefinitionfunction.md) | :heavy_check_mark:                                                                                 | The function definition                                                                            |