# ImageGenerationResponse

Response from the image generation endpoint containing the generated images and metadata.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Created`                                                                                  | *double*                                                                                   | :heavy_check_mark:                                                                         | The Unix timestamp (in seconds) of when the image generation was completed.                |
| `Data`                                                                                     | List<[ImageGenerationResponseData](../../Types/Components/ImageGenerationResponseData.md)> | :heavy_check_mark:                                                                         | A list of image objects containing the generated image data.                               |