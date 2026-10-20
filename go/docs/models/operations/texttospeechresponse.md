# TextToSpeechResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |
| `ResponseStream`                                                   | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | Audio file in WAV format with language code header                 |
| `Headers`                                                          | map[string][]`string`                                              | :heavy_check_mark:                                                 | N/A                                                                |