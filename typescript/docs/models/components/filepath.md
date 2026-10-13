# FilePath

Annotation for referencing a file path in the model's output. Used when the model mentions specific files.

## Example Usage

```typescript
import { FilePath } from "@meetkai/mka1/models/components";

let value: FilePath = {
  type: "file_path",
  fileId: "<id>",
  index: 436278,
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *"file_path"*                                                                  | :heavy_check_mark:                                                             | The annotation type identifier for file path references.                       |
| `fileId`                                                                       | *string*                                                                       | :heavy_check_mark:                                                             | The ID of the file being referenced.                                           |
| `index`                                                                        | *number*                                                                       | :heavy_check_mark:                                                             | The character index in the output text where this file path reference applies. |