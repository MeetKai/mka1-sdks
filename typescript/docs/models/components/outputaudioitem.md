# OutputAudioItem

Output audio item: Audio content synthesized from the model's text response via TTS.

## Example Usage

```typescript
import { OutputAudioItem } from "@meetkai/mka1/models/components";

let value: OutputAudioItem = {
  type: "output_audio",
  data: "<value>",
  transcript: "<value>",
  id: "<id>",
  status: "incomplete",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `type`                                                                               | *"output_audio"*                                                                     | :heavy_check_mark:                                                                   | The content type identifier for audio output.                                        |
| `data`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | Base64-encoded audio data.                                                           |
| `transcript`                                                                         | *string*                                                                             | :heavy_check_mark:                                                                   | The text transcript that was synthesized into audio.                                 |
| `id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | The unique identifier for this output audio item.                                    |
| `status`                                                                             | [components.OutputAudioItemStatus](../../models/components/outputaudioitemstatus.md) | :heavy_check_mark:                                                                   | The processing status of this audio item.                                            |