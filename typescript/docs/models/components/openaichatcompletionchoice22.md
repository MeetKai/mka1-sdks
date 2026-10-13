# OpenAIChatCompletionChoice22

## Example Usage

```typescript
import { OpenAIChatCompletionChoice22 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoice22 = {
  type: "image_url",
  imageUrl: {
    url: "https://bruised-brace.info/",
  },
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `type`                                                           | *"image_url"*                                                    | :heavy_check_mark:                                               | Content type identifier for image URL content                    |
| `imageUrl`                                                       | [components.TwoImageUrl](../../models/components/twoimageurl.md) | :heavy_check_mark:                                               | N/A                                                              |