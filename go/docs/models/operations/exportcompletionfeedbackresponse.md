# ExportCompletionFeedbackResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |
| `ResponseStream`                                                   | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | CSV file containing the feedback entries visible to the caller     |
| `Headers`                                                          | map[string][]`string`                                              | :heavy_check_mark:                                                 | N/A                                                                |