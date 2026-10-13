# OutputAudioItemWithId

Output audio item: Audio content synthesized from the model's text response via TTS.

## Example Usage

```typescript
import { OutputAudioItemWithId } from "@meetkai/mka1/models/components";

let value: OutputAudioItemWithId = {
  type: "output_audio",
  data: "<value>",
  transcript: "<value>",
  id: "<id>",
  status: "in_progress",
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `type`                                                                                           | *"output_audio"*                                                                                 | :heavy_check_mark:                                                                               | The content type identifier for audio output.                                                    |
| `data`                                                                                           | *string*                                                                                         | :heavy_check_mark:                                                                               | Base64-encoded audio data.                                                                       |
| `transcript`                                                                                     | *string*                                                                                         | :heavy_check_mark:                                                                               | The text transcript that was synthesized into audio.                                             |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | The unique ID of the message.                                                                    |
| `status`                                                                                         | [components.OutputAudioItemWithIdStatus](../../models/components/outputaudioitemwithidstatus.md) | :heavy_check_mark:                                                                               | The processing status of this audio item.                                                        |
| `responseId`                                                                                     | *string*                                                                                         | :heavy_minus_sign:                                                                               | The ID of the response that created this item, if any.                                           |
| `metadata`                                                                                       | Record<string, *string*>                                                                         | :heavy_minus_sign:                                                                               | Metadata from the response that created this item, if any.                                       |