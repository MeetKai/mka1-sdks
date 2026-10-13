# VectorStoreFileContent

The parsed contents of a vector store file.

## Example Usage

```typescript
import { VectorStoreFileContent } from "@meetkai/mka1/models/components";

let value: VectorStoreFileContent = {
  fileId: "<id>",
  filename: "example.file",
  content: [],
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `fileId`                                                                   | *string*                                                                   | :heavy_check_mark:                                                         | The ID of the file.                                                        |
| `filename`                                                                 | *string*                                                                   | :heavy_check_mark:                                                         | The name of the file.                                                      |
| `attributes`                                                               | Record<string, *components.VectorStoreFileContentAttributes*>              | :heavy_minus_sign:                                                         | File attributes.                                                           |
| `content`                                                                  | [components.FileContentItem](../../models/components/filecontentitem.md)[] | :heavy_check_mark:                                                         | Array of parsed content items from the file.                               |