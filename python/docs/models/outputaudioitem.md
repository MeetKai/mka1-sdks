# OutputAudioItem

Output audio item: Audio content synthesized from the model's text response via TTS.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `type`                                                             | *Literal["output_audio"]*                                          | :heavy_check_mark:                                                 | The content type identifier for audio output.                      |
| `data`                                                             | *str*                                                              | :heavy_check_mark:                                                 | Base64-encoded audio data.                                         |
| `transcript`                                                       | *str*                                                              | :heavy_check_mark:                                                 | The text transcript that was synthesized into audio.               |
| `id`                                                               | *str*                                                              | :heavy_check_mark:                                                 | The unique identifier for this output audio item.                  |
| `status`                                                           | [models.OutputAudioItemStatus](../models/outputaudioitemstatus.md) | :heavy_check_mark:                                                 | The processing status of this audio item.                          |