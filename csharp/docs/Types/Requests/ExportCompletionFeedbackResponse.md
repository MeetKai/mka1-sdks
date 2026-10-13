# ExportCompletionFeedbackResponse


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `HttpMeta`                                                     | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)         | :heavy_check_mark:                                             | N/A                                                            |
| `Bytes`                                                        | *byte[]*                                                       | :heavy_minus_sign:                                             | CSV file containing the feedback entries visible to the caller |
| `Headers`                                                      | Dictionary<String, List<*string*>>                             | :heavy_check_mark:                                             | N/A                                                            |