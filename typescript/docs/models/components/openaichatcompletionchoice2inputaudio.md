# OpenAIChatCompletionChoice2InputAudio

## Example Usage

```typescript
import { OpenAIChatCompletionChoice2InputAudio } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoice2InputAudio = {
  data: "<value>",
  format: "mp3",
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `data`                                                                                                       | *string*                                                                                                     | :heavy_check_mark:                                                                                           | Base64-encoded audio data                                                                                    |
| `format`                                                                                                     | [components.OpenAIChatCompletionChoice2Format](../../models/components/openaichatcompletionchoice2format.md) | :heavy_check_mark:                                                                                           | The format of the encoded audio data                                                                         |