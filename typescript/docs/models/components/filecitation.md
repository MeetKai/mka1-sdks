# FileCitation

Annotation for citing a specific file in the model's output. Used when the model references information from a file.

## Example Usage

```typescript
import { FileCitation } from "@meetkai/mka1/models/components";

let value: FileCitation = {
  type: "file_citation",
  fileId: "<id>",
  filename: "example.file",
  index: 975429,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `type`                                                              | *"file_citation"*                                                   | :heavy_check_mark:                                                  | The annotation type identifier for file citations.                  |
| `fileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | The ID of the file being cited.                                     |
| `filename`                                                          | *string*                                                            | :heavy_check_mark:                                                  | The name of the file being cited.                                   |
| `index`                                                             | *number*                                                            | :heavy_check_mark:                                                  | The character index in the output text where this citation applies. |