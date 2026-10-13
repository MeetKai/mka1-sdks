# TextToSpeechHistoryObject

A stored text-to-speech generation.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | Unique identifier for the history item.                    |
| `object`                                                   | *Literal["speech.tts"]*                                    | :heavy_check_mark:                                         | The object type, always 'speech.tts'.                      |
| `text`                                                     | *str*                                                      | :heavy_check_mark:                                         | The input text that was synthesized.                       |
| `language`                                                 | *str*                                                      | :heavy_check_mark:                                         | The requested language ('auto' or an ISO 639-1 code).      |
| `detected_language`                                        | *Nullable[str]*                                            | :heavy_check_mark:                                         | The language actually used for synthesis.                  |
| `model`                                                    | *str*                                                      | :heavy_check_mark:                                         | The TTS model used.                                        |
| `provider_id`                                              | *Nullable[str]*                                            | :heavy_check_mark:                                         | The provider that produced the audio.                      |
| `format_`                                                  | *str*                                                      | :heavy_check_mark:                                         | Audio format of the stored output (wav, mp3, or pcm).      |
| `audio_bytes`                                              | *int*                                                      | :heavy_check_mark:                                         | Size of the generated audio in bytes.                      |
| `characters`                                               | *int*                                                      | :heavy_check_mark:                                         | Number of characters in the input text.                    |
| `streaming`                                                | *bool*                                                     | :heavy_check_mark:                                         | Whether the audio was produced via the streaming endpoint. |
| `metadata`                                                 | Dict[str, *Any*]                                           | :heavy_check_mark:                                         | Arbitrary metadata stored with the item.                   |
| `created_at`                                               | *int*                                                      | :heavy_check_mark:                                         | Unix timestamp (seconds) when the item was created.        |