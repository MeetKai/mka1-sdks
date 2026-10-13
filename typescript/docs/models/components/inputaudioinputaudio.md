# InputAudioInputAudio

The audio data and its format.

## Example Usage

```typescript
import { InputAudioInputAudio } from "@meetkai/mka1/models/components";

let value: InputAudioInputAudio = {
  data: "<value>",
  format: "wav",
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `data`                                                                     | *string*                                                                   | :heavy_check_mark:                                                         | Base64-encoded audio data to send to the model.                            |
| `format`                                                                   | [components.InputAudioFormat](../../models/components/inputaudioformat.md) | :heavy_check_mark:                                                         | The audio format/codec. Supported formats are 'mp3' and 'wav'.             |