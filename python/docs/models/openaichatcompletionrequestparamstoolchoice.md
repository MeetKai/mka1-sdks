# OpenAIChatCompletionRequestParamsToolChoice

Forces the model to call a specific function


## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                     | *Literal["function"]*                                                                                      | :heavy_check_mark:                                                                                         | The type of the tool. Currently only 'function' is supported.                                              |
| `function`                                                                                                 | [models.OpenAIChatCompletionRequestParamsFunction](../models/openaichatcompletionrequestparamsfunction.md) | :heavy_check_mark:                                                                                         | The function to call                                                                                       |