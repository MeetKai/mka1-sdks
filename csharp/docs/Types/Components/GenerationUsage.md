# GenerationUsage

api.md §3 `usage`, the shape of the runtime's `llm.Usage`.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Calls`                                                                                    | *long*                                                                                     | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `InputTokens`                                                                              | *long*                                                                                     | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `OutputTokens`                                                                             | *long*                                                                                     | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `ByModel`                                                                                  | Dictionary<String, [GenerationModelUsage](../../Types/Components/GenerationModelUsage.md)> | :heavy_minus_sign:                                                                         | N/A                                                                                        |