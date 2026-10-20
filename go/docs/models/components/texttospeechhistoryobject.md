# TextToSpeechHistoryObject

A stored text-to-speech generation.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | Unique identifier for the history item.                    |
| `Object`                                                   | `string`                                                   | :heavy_check_mark:                                         | The object type, always 'speech.tts'.                      |
| `Text`                                                     | `string`                                                   | :heavy_check_mark:                                         | The input text that was synthesized.                       |
| `Language`                                                 | `string`                                                   | :heavy_check_mark:                                         | The requested language ('auto' or an ISO 639-1 code).      |
| `DetectedLanguage`                                         | `*string`                                                  | :heavy_check_mark:                                         | The language actually used for synthesis.                  |
| `Model`                                                    | `string`                                                   | :heavy_check_mark:                                         | The TTS model used.                                        |
| `ProviderID`                                               | `*string`                                                  | :heavy_check_mark:                                         | The provider that produced the audio.                      |
| `Format`                                                   | `string`                                                   | :heavy_check_mark:                                         | Audio format of the stored output (wav, mp3, or pcm).      |
| `AudioBytes`                                               | `int64`                                                    | :heavy_check_mark:                                         | Size of the generated audio in bytes.                      |
| `Characters`                                               | `int64`                                                    | :heavy_check_mark:                                         | Number of characters in the input text.                    |
| `Streaming`                                                | `bool`                                                     | :heavy_check_mark:                                         | Whether the audio was produced via the streaming endpoint. |
| `Metadata`                                                 | map[string]`any`                                           | :heavy_check_mark:                                         | Arbitrary metadata stored with the item.                   |
| `CreatedAt`                                                | `int64`                                                    | :heavy_check_mark:                                         | Unix timestamp (seconds) when the item was created.        |