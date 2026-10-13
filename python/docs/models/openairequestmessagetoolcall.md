# OpenAIRequestMessageToolCall


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `id`                                                                             | *str*                                                                            | :heavy_check_mark:                                                               | The ID of the tool call                                                          |
| `type`                                                                           | *Literal["function"]*                                                            | :heavy_check_mark:                                                               | The type of the tool. Currently only 'function' is supported.                    |
| `function`                                                                       | [models.OpenAIRequestMessageFunction](../models/openairequestmessagefunction.md) | :heavy_check_mark:                                                               | The function to be called                                                        |