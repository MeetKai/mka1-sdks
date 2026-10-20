# TextToSpeechStreamingResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |
| `TwoHundredAudioMpegResponseStream`                                | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | Streaming audio in MP3 or PCM/WAV format with language code header |
| `TwoHundredAudioWavResponseStream`                                 | `io.ReadCloser`                                                    | :heavy_minus_sign:                                                 | Streaming audio in MP3 or PCM/WAV format with language code header |
| `Headers`                                                          | map[string][]`string`                                              | :heavy_check_mark:                                                 | N/A                                                                |