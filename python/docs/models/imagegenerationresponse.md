# ImageGenerationResponse

Response from the image generation endpoint containing the generated images and metadata.


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `created`                                                                            | *float*                                                                              | :heavy_check_mark:                                                                   | The Unix timestamp (in seconds) of when the image generation was completed.          |
| `data`                                                                               | List[[models.ImageGenerationResponseData](../models/imagegenerationresponsedata.md)] | :heavy_check_mark:                                                                   | A list of image objects containing the generated image data.                         |