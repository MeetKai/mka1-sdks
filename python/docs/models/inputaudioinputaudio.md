# InputAudioInputAudio

The audio data and its format.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `data`                                                         | *str*                                                          | :heavy_check_mark:                                             | Base64-encoded audio data to send to the model.                |
| `format_`                                                      | [models.InputAudioFormat](../models/inputaudioformat.md)       | :heavy_check_mark:                                             | The audio format/codec. Supported formats are 'mp3' and 'wav'. |