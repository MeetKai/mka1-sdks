# OpenAIChatCompletionChunk2InputAudio

## Example Usage

```typescript
import { OpenAIChatCompletionChunk2InputAudio } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunk2InputAudio = {
  data: "<value>",
  format: "mp3",
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `data`                                                                                                     | *string*                                                                                                   | :heavy_check_mark:                                                                                         | Base64-encoded audio data                                                                                  |
| `format`                                                                                                   | [components.OpenAIChatCompletionChunk2Format](../../models/components/openaichatcompletionchunk2format.md) | :heavy_check_mark:                                                                                         | The format of the encoded audio data                                                                       |