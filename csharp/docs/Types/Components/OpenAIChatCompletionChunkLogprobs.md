# OpenAIChatCompletionChunkLogprobs

Log probability information for the choice


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Tokens`                                                                    | List<*string*>                                                              | :heavy_check_mark:                                                          | The list of tokens                                                          |
| `TokenLogprobs`                                                             | List<*double*>                                                              | :heavy_check_mark:                                                          | The log probability of each token                                           |
| `TopLogprobs`                                                               | List<Dictionary<String, *double*>>                                          | :heavy_check_mark:                                                          | The top log probabilities for each token position                           |
| `TextOffset`                                                                | List<*long*>                                                                | :heavy_check_mark:                                                          | The character offset from the beginning of the returned text for each token |