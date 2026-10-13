# Two3

## Example Usage

```typescript
import { Two3 } from "@meetkai/mka1/models/components";

let value: Two3 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"input_audio"*                                                      | :heavy_check_mark:                                                   | Content type identifier for audio input content                      |
| `inputAudio`                                                         | [components.TwoInputAudio](../../models/components/twoinputaudio.md) | :heavy_check_mark:                                                   | N/A                                                                  |