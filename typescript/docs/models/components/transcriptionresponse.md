# TranscriptionResponse

Response from the transcription endpoint containing the transcribed text, detected language, confidence score, and optional speaker segments.

## Example Usage

```typescript
import { TranscriptionResponse } from "@meetkai/mka1/models/components";

let value: TranscriptionResponse = {
  text: "Hello, this is a sample transcription of the audio file.",
  language: "en",
  confidence: 0.95,
  speakers: [
    {
      speaker: "Speaker-1",
      text: "Hello, this is a sample transcription of the audio file.",
      confidence: 0.95,
      offsetMs: 0,
      durationMs: 2100,
    },
  ],
};
```

## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `text`                                                                                      | *string*                                                                                    | :heavy_check_mark:                                                                          | The transcribed text from the audio file                                                    |
| `language`                                                                                  | *string*                                                                                    | :heavy_minus_sign:                                                                          | The detected or specified language code in ISO-639-1 format (e.g., 'en', 'es', 'fr')        |
| `confidence`                                                                                | *number*                                                                                    | :heavy_minus_sign:                                                                          | Confidence score from 0 to 1 where 1 indicates highest confidence in transcription accuracy |
| `speakers`                                                                                  | [components.SpeakerSegment](../../models/components/speakersegment.md)[]                    | :heavy_minus_sign:                                                                          | Speaker diarization segments, returned only when include_speaker_data is true.              |