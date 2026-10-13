# OpenAIChatCompletionChunkFile1

## Example Usage

```typescript
import { OpenAIChatCompletionChunkFile1 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunkFile1 = {
  filename: "example.file",
  fileData: "<value>",
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `filename`               | *string*                 | :heavy_check_mark:       | The name of the file     |
| `fileData`               | *string*                 | :heavy_check_mark:       | Base64-encoded file data |