# ImageGenerationCallWithId

Image generation call item: A tool-call record for image generation, including status and result URL.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `Status`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Result`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Background`                                               | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `OutputFormat`                                             | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `Quality`                                                  | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `Size`                                                     | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `RevisedPrompt`                                            | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `ResponseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | Dictionary<String, *string*>                               | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |