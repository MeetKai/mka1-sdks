# TextToSpeechHistoryObject

A stored text-to-speech generation.

## Example Usage

```typescript
import { TextToSpeechHistoryObject } from "@meetkai/mka1/models/components";

let value: TextToSpeechHistoryObject = {
  id: "<id>",
  object: "speech.tts",
  text: "<value>",
  language: "<value>",
  detectedLanguage: "<value>",
  model: "2",
  providerId: "<id>",
  format: "<value>",
  audioBytes: 537031,
  characters: 273565,
  streaming: true,
  metadata: {
    "key": "<value>",
  },
  createdAt: 239871,
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | Unique identifier for the history item.                    |
| `object`                                                   | *"speech.tts"*                                             | :heavy_check_mark:                                         | The object type, always 'speech.tts'.                      |
| `text`                                                     | *string*                                                   | :heavy_check_mark:                                         | The input text that was synthesized.                       |
| `language`                                                 | *string*                                                   | :heavy_check_mark:                                         | The requested language ('auto' or an ISO 639-1 code).      |
| `detectedLanguage`                                         | *string*                                                   | :heavy_check_mark:                                         | The language actually used for synthesis.                  |
| `model`                                                    | *string*                                                   | :heavy_check_mark:                                         | The TTS model used.                                        |
| `providerId`                                               | *string*                                                   | :heavy_check_mark:                                         | The provider that produced the audio.                      |
| `format`                                                   | *string*                                                   | :heavy_check_mark:                                         | Audio format of the stored output (wav, mp3, or pcm).      |
| `audioBytes`                                               | *number*                                                   | :heavy_check_mark:                                         | Size of the generated audio in bytes.                      |
| `characters`                                               | *number*                                                   | :heavy_check_mark:                                         | Number of characters in the input text.                    |
| `streaming`                                                | *boolean*                                                  | :heavy_check_mark:                                         | Whether the audio was produced via the streaming endpoint. |
| `metadata`                                                 | Record<string, *any*>                                      | :heavy_check_mark:                                         | Arbitrary metadata stored with the item.                   |
| `createdAt`                                                | *number*                                                   | :heavy_check_mark:                                         | Unix timestamp (seconds) when the item was created.        |