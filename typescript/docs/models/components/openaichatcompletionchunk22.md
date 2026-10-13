# OpenAIChatCompletionChunk22

## Example Usage

```typescript
import { OpenAIChatCompletionChunk22 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunk22 = {
  type: "image_url",
  imageUrl: {
    url: "https://colossal-statue.net/",
  },
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                         | *"image_url"*                                                                                                  | :heavy_check_mark:                                                                                             | Content type identifier for image URL content                                                                  |
| `imageUrl`                                                                                                     | [components.OpenAIChatCompletionChunk2ImageUrl](../../models/components/openaichatcompletionchunk2imageurl.md) | :heavy_check_mark:                                                                                             | N/A                                                                                                            |