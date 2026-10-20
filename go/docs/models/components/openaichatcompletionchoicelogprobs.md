# OpenAIChatCompletionChoiceLogprobs

Log probability information for the choice


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Tokens`                                                                    | []`string`                                                                  | :heavy_check_mark:                                                          | The list of tokens                                                          |
| `TokenLogprobs`                                                             | []`float64`                                                                 | :heavy_check_mark:                                                          | The log probability of each token                                           |
| `TopLogprobs`                                                               | []map[string]`float64`                                                      | :heavy_check_mark:                                                          | The top log probabilities for each token position                           |
| `TextOffset`                                                                | []`int64`                                                                   | :heavy_check_mark:                                                          | The character offset from the beginning of the returned text for each token |