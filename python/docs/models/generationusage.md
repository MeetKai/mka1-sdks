# GenerationUsage

api.md §3 `usage`, the shape of the runtime's `llm.Usage`.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `calls`                                                                     | *Optional[int]*                                                             | :heavy_minus_sign:                                                          | N/A                                                                         |
| `input_tokens`                                                              | *Optional[int]*                                                             | :heavy_minus_sign:                                                          | N/A                                                                         |
| `output_tokens`                                                             | *Optional[int]*                                                             | :heavy_minus_sign:                                                          | N/A                                                                         |
| `by_model`                                                                  | Dict[str, [models.GenerationModelUsage](../models/generationmodelusage.md)] | :heavy_minus_sign:                                                          | N/A                                                                         |