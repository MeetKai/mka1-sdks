# SpeechToTextHistoryObject

A stored speech-to-text transcription.

## Example Usage

```typescript
import { SpeechToTextHistoryObject } from "@meetkai/mka1/models/components";

let value: SpeechToTextHistoryObject = {
  id: "<id>",
  object: "speech.transcription",
  text: "<value>",
  language: "<value>",
  confidence: 3762.12,
  model: "Wrangler",
  providerId: "<id>",
  filename: null,
  audioBytes: 464526,
  audioMimeType: "<value>",
  speakers: [
    {
      speaker: "<value>",
      text: "<value>",
    },
  ],
  streaming: true,
  metadata: {
    "key": "<value>",
    "key1": "<value>",
  },
  createdAt: 700793,
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | Unique identifier for the history item.                                  |
| `object`                                                                 | *"speech.transcription"*                                                 | :heavy_check_mark:                                                       | The object type, always 'speech.transcription'.                          |
| `text`                                                                   | *string*                                                                 | :heavy_check_mark:                                                       | The transcribed text.                                                    |
| `language`                                                               | *string*                                                                 | :heavy_check_mark:                                                       | The detected or specified language code.                                 |
| `confidence`                                                             | *number*                                                                 | :heavy_check_mark:                                                       | Confidence score from 0 to 1, when available.                            |
| `model`                                                                  | *string*                                                                 | :heavy_check_mark:                                                       | The transcription model used.                                            |
| `providerId`                                                             | *string*                                                                 | :heavy_check_mark:                                                       | The provider that produced the transcription.                            |
| `filename`                                                               | *string*                                                                 | :heavy_check_mark:                                                       | Original filename of the input audio, when available.                    |
| `audioBytes`                                                             | *number*                                                                 | :heavy_check_mark:                                                       | Size of the input audio in bytes.                                        |
| `audioMimeType`                                                          | *string*                                                                 | :heavy_check_mark:                                                       | MIME type of the stored input audio.                                     |
| `speakers`                                                               | [components.SpeakerSegment](../../models/components/speakersegment.md)[] | :heavy_check_mark:                                                       | Speaker diarization segments, when present.                              |
| `streaming`                                                              | *boolean*                                                                | :heavy_check_mark:                                                       | Whether the transcription came from the streaming WebSocket.             |
| `metadata`                                                               | Record<string, *any*>                                                    | :heavy_check_mark:                                                       | Arbitrary metadata stored with the item.                                 |
| `createdAt`                                                              | *number*                                                                 | :heavy_check_mark:                                                       | Unix timestamp (seconds) when the item was created.                      |