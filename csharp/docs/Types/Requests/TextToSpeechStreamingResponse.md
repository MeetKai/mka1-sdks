# TextToSpeechStreamingResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `HttpMeta`                                                         | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)             | :heavy_check_mark:                                                 | N/A                                                                |
| `TwoHundredAudioMpegBytes`                                         | *byte[]*                                                           | :heavy_minus_sign:                                                 | Streaming audio in MP3 or PCM/WAV format with language code header |
| `TwoHundredAudioWavBytes`                                          | *byte[]*                                                           | :heavy_minus_sign:                                                 | Streaming audio in MP3 or PCM/WAV format with language code header |
| `Headers`                                                          | Dictionary<String, List<*string*>>                                 | :heavy_check_mark:                                                 | N/A                                                                |