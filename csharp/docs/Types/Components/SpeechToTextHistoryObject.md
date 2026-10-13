# SpeechToTextHistoryObject

A stored speech-to-text transcription.


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `Id`                                                             | *string*                                                         | :heavy_check_mark:                                               | Unique identifier for the history item.                          |
| `Object`                                                         | *string*                                                         | :heavy_check_mark:                                               | The object type, always 'speech.transcription'.                  |
| `Text`                                                           | *string*                                                         | :heavy_check_mark:                                               | The transcribed text.                                            |
| `Language`                                                       | *string*                                                         | :heavy_check_mark:                                               | The detected or specified language code.                         |
| `Confidence`                                                     | *double*                                                         | :heavy_check_mark:                                               | Confidence score from 0 to 1, when available.                    |
| `Model`                                                          | *string*                                                         | :heavy_check_mark:                                               | The transcription model used.                                    |
| `ProviderId`                                                     | *string*                                                         | :heavy_check_mark:                                               | The provider that produced the transcription.                    |
| `Filename`                                                       | *string*                                                         | :heavy_check_mark:                                               | Original filename of the input audio, when available.            |
| `AudioBytes`                                                     | *long*                                                           | :heavy_check_mark:                                               | Size of the input audio in bytes.                                |
| `AudioMimeType`                                                  | *string*                                                         | :heavy_check_mark:                                               | MIME type of the stored input audio.                             |
| `Speakers`                                                       | List<[SpeakerSegment](../../Types/Components/SpeakerSegment.md)> | :heavy_check_mark:                                               | Speaker diarization segments, when present.                      |
| `Streaming`                                                      | *bool*                                                           | :heavy_check_mark:                                               | Whether the transcription came from the streaming WebSocket.     |
| `Metadata`                                                       | Dictionary<String, *object*>                                     | :heavy_check_mark:                                               | Arbitrary metadata stored with the item.                         |
| `CreatedAt`                                                      | *long*                                                           | :heavy_check_mark:                                               | Unix timestamp (seconds) when the item was created.              |