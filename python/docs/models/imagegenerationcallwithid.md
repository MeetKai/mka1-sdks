# ImageGenerationCallWithID

Image generation call item: A tool-call record for image generation, including status and result URL.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["image_generation_call"]*                         | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `status`                                                   | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `result`                                                   | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `background`                                               | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `output_format`                                            | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `quality`                                                  | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `size`                                                     | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `revised_prompt`                                           | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |