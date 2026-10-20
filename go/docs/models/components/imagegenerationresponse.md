# ImageGenerationResponse

Response from the image generation endpoint containing the generated images and metadata.


## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Created`                                                                                          | `float64`                                                                                          | :heavy_check_mark:                                                                                 | The Unix timestamp (in seconds) of when the image generation was completed.                        |
| `Data`                                                                                             | [][components.ImageGenerationResponseData](../../models/components/imagegenerationresponsedata.md) | :heavy_check_mark:                                                                                 | A list of image objects containing the generated image data.                                       |