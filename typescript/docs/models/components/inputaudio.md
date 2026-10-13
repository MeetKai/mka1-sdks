# InputAudio

Input audio content item: Audio input for speech processing and transcription.

## Example Usage

```typescript
import { InputAudio } from "@meetkai/mka1/models/components";

let value: InputAudio = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `type`                                                                             | *"input_audio"*                                                                    | :heavy_check_mark:                                                                 | The content type identifier for audio input.                                       |
| `inputAudio`                                                                       | [components.InputAudioInputAudio](../../models/components/inputaudioinputaudio.md) | :heavy_check_mark:                                                                 | The audio data and its format.                                                     |