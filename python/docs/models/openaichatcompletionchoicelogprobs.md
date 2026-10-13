# OpenAIChatCompletionChoiceLogprobs

Log probability information for the choice


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `tokens`                                                                    | List[*str*]                                                                 | :heavy_check_mark:                                                          | The list of tokens                                                          |
| `token_logprobs`                                                            | List[*float*]                                                               | :heavy_check_mark:                                                          | The log probability of each token                                           |
| `top_logprobs`                                                              | List[Dict[str, *float*]]                                                    | :heavy_check_mark:                                                          | The top log probabilities for each token position                           |
| `text_offset`                                                               | List[*int*]                                                                 | :heavy_check_mark:                                                          | The character offset from the beginning of the returned text for each token |