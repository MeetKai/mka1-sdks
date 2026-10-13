# OpenAIChatCompletionChoice21

## Example Usage

```typescript
import { OpenAIChatCompletionChoice21 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoice21 = {
  type: "text",
  text: "<value>",
};
```

## Fields

| Field                                      | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `type`                                     | *"text"*                                   | :heavy_check_mark:                         | Content type identifier for text content   |
| `text`                                     | *string*                                   | :heavy_check_mark:                         | The text content to include in the message |