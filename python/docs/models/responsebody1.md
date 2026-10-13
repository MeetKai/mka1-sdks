# ResponseBody1


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `event`                                                                    | *Literal["message"]*                                                       | :heavy_check_mark:                                                         | N/A                                                                        |
| `data`                                                                     | [models.OpenAIChatCompletionChunk](../models/openaichatcompletionchunk.md) | :heavy_check_mark:                                                         | Represents a streamed chunk of a chat completion response                  |
| `id`                                                                       | *Optional[str]*                                                            | :heavy_minus_sign:                                                         | N/A                                                                        |
| `retry`                                                                    | *Optional[int]*                                                            | :heavy_minus_sign:                                                         | N/A                                                                        |