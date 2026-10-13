# ImageGenerationResponseData

An individual image object in the response.


## Fields

| Field                                                                                               | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `Url`                                                                                               | *string*                                                                                            | :heavy_minus_sign:                                                                                  | The URL of the generated image, if response_format is 'url' (default). The URL is valid for 1 hour. |
| `B64Json`                                                                                           | *string*                                                                                            | :heavy_minus_sign:                                                                                  | The base64-encoded JSON of the generated image, if response_format is 'b64_json'.                   |
| `RevisedPrompt`                                                                                     | *string*                                                                                            | :heavy_minus_sign:                                                                                  | The prompt that was used to generate the image, if there was any revision to the prompt.            |