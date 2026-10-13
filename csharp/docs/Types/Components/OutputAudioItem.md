# OutputAudioItem

Output audio item: Audio content synthesized from the model's text response via TTS.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Type`                                                                   | *string*                                                                 | :heavy_check_mark:                                                       | The content type identifier for audio output.                            |
| `Data`                                                                   | *string*                                                                 | :heavy_check_mark:                                                       | Base64-encoded audio data.                                               |
| `Transcript`                                                             | *string*                                                                 | :heavy_check_mark:                                                       | The text transcript that was synthesized into audio.                     |
| `Id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | The unique identifier for this output audio item.                        |
| `Status`                                                                 | [OutputAudioItemStatus](../../Types/Components/OutputAudioItemStatus.md) | :heavy_check_mark:                                                       | The processing status of this audio item.                                |