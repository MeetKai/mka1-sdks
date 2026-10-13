# TwoImageUrl

## Example Usage

```typescript
import { TwoImageUrl } from "@meetkai/mka1/models/components";

let value: TwoImageUrl = {
  url: "https://dependent-patroller.org",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `url`                                                                                                                  | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | The URL of the image, or a base64-encoded image data URL                                                               |
| `detail`                                                                                                               | [components.OpenAIChatCompletionChoice2Detail](../../models/components/openaichatcompletionchoice2detail.md)           | :heavy_minus_sign:                                                                                                     | The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide. |