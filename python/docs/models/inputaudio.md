# InputAudio

Input audio content item: Audio input for speech processing and transcription.


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `type`                                                           | *Literal["input_audio"]*                                         | :heavy_check_mark:                                               | The content type identifier for audio input.                     |
| `input_audio`                                                    | [models.InputAudioInputAudio](../models/inputaudioinputaudio.md) | :heavy_check_mark:                                               | The audio data and its format.                                   |