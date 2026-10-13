# OpenAIChatCompletionChoice24

## Example Usage

```typescript
import { OpenAIChatCompletionChoice24 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoice24 = {
  type: "file",
  file: {
    fileId: "<id>",
  },
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *"file"*                                                               | :heavy_check_mark:                                                     | Content type identifier for file content                               |
| `file`                                                                 | *components.OpenAIChatCompletionChoice2File*                           | :heavy_check_mark:                                                     | The file to include in the message, either as raw data or by reference |