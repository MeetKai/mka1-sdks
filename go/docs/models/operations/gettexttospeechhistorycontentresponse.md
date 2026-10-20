# GetTextToSpeechHistoryContentResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |
| `TwoHundredAudioWavResponseStream`                                 | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | Stored audio file                                                  |
| `TwoHundredAudioMpegResponseStream`                                | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | Stored audio file                                                  |