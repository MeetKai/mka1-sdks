# SpeechToTextHistoryObject

A stored speech-to-text transcription.


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `id`                                                         | *str*                                                        | :heavy_check_mark:                                           | Unique identifier for the history item.                      |
| `object`                                                     | *Literal["speech.transcription"]*                            | :heavy_check_mark:                                           | The object type, always 'speech.transcription'.              |
| `text`                                                       | *str*                                                        | :heavy_check_mark:                                           | The transcribed text.                                        |
| `language`                                                   | *Nullable[str]*                                              | :heavy_check_mark:                                           | The detected or specified language code.                     |
| `confidence`                                                 | *Nullable[float]*                                            | :heavy_check_mark:                                           | Confidence score from 0 to 1, when available.                |
| `model`                                                      | *str*                                                        | :heavy_check_mark:                                           | The transcription model used.                                |
| `provider_id`                                                | *Nullable[str]*                                              | :heavy_check_mark:                                           | The provider that produced the transcription.                |
| `filename`                                                   | *Nullable[str]*                                              | :heavy_check_mark:                                           | Original filename of the input audio, when available.        |
| `audio_bytes`                                                | *int*                                                        | :heavy_check_mark:                                           | Size of the input audio in bytes.                            |
| `audio_mime_type`                                            | *Nullable[str]*                                              | :heavy_check_mark:                                           | MIME type of the stored input audio.                         |
| `speakers`                                                   | List[[models.SpeakerSegment](../models/speakersegment.md)]   | :heavy_check_mark:                                           | Speaker diarization segments, when present.                  |
| `streaming`                                                  | *bool*                                                       | :heavy_check_mark:                                           | Whether the transcription came from the streaming WebSocket. |
| `metadata`                                                   | Dict[str, *Any*]                                             | :heavy_check_mark:                                           | Arbitrary metadata stored with the item.                     |
| `created_at`                                                 | *int*                                                        | :heavy_check_mark:                                           | Unix timestamp (seconds) when the item was created.          |