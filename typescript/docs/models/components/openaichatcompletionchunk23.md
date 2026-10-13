# OpenAIChatCompletionChunk23

## Example Usage

```typescript
import { OpenAIChatCompletionChunk23 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunk23 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                             | *"input_audio"*                                                                                                    | :heavy_check_mark:                                                                                                 | Content type identifier for audio input content                                                                    |
| `inputAudio`                                                                                                       | [components.OpenAIChatCompletionChunk2InputAudio](../../models/components/openaichatcompletionchunk2inputaudio.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |