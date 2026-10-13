# ClassificationResponse

Response from the text classification endpoint containing the classification result, confidence, and metadata.


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `success`                                                                            | *bool*                                                                               | :heavy_check_mark:                                                                   | Indicates whether the classification request was successful                          |
| `data`                                                                               | [models.ClassificationResponseData](../models/classificationresponsedata.md)         | :heavy_check_mark:                                                                   | The classification result data                                                       |
| `metadata`                                                                           | [models.ClassificationResponseMetadata](../models/classificationresponsemetadata.md) | :heavy_check_mark:                                                                   | Metadata about the classification request and execution                              |