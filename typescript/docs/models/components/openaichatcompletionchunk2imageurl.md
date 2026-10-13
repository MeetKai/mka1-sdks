# OpenAIChatCompletionChunk2ImageUrl

## Example Usage

```typescript
import { OpenAIChatCompletionChunk2ImageUrl } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunk2ImageUrl = {
  url: "https://ambitious-ignorance.name/",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `url`                                                                                                                  | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | The URL of the image, or a base64-encoded image data URL                                                               |
| `detail`                                                                                                               | [components.OpenAIChatCompletionChunk2Detail](../../models/components/openaichatcompletionchunk2detail.md)             | :heavy_minus_sign:                                                                                                     | The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide. |