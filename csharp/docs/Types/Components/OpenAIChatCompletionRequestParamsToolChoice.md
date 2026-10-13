# OpenAIChatCompletionRequestParamsToolChoice

Forces the model to call a specific function


## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `Type`                                                                                                           | *string*                                                                                                         | :heavy_check_mark:                                                                                               | The type of the tool. Currently only 'function' is supported.                                                    |
| `Function`                                                                                                       | [OpenAIChatCompletionRequestParamsFunction](../../Types/Components/OpenAIChatCompletionRequestParamsFunction.md) | :heavy_check_mark:                                                                                               | The function to call                                                                                             |