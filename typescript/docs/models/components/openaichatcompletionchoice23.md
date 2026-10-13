# OpenAIChatCompletionChoice23

## Example Usage

```typescript
import { OpenAIChatCompletionChoice23 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoice23 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "wav",
  },
};
```

## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                               | *"input_audio"*                                                                                                      | :heavy_check_mark:                                                                                                   | Content type identifier for audio input content                                                                      |
| `inputAudio`                                                                                                         | [components.OpenAIChatCompletionChoice2InputAudio](../../models/components/openaichatcompletionchoice2inputaudio.md) | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |