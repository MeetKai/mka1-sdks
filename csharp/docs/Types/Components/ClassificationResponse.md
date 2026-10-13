# ClassificationResponse

Response from the text classification endpoint containing the classification result, confidence, and metadata.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Success`                                                                                  | *bool*                                                                                     | :heavy_check_mark:                                                                         | Indicates whether the classification request was successful                                |
| `Data`                                                                                     | [ClassificationResponseData](../../Types/Components/ClassificationResponseData.md)         | :heavy_check_mark:                                                                         | The classification result data                                                             |
| `Metadata`                                                                                 | [ClassificationResponseMetadata](../../Types/Components/ClassificationResponseMetadata.md) | :heavy_check_mark:                                                                         | Metadata about the classification request and execution                                    |