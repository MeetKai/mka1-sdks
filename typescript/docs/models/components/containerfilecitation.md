# ContainerFileCitation

Annotation for citing a file within a specific container (like a code interpreter sandbox). Used when the model references files generated within tool executions.

## Example Usage

```typescript
import { ContainerFileCitation } from "@meetkai/mka1/models/components";

let value: ContainerFileCitation = {
  type: "container_file_citation",
  containerId: "<id>",
  endIndex: 175953,
  fileId: "<id>",
  filename: "example.file",
  startIndex: 741088,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `type`                                                                             | *"container_file_citation"*                                                        | :heavy_check_mark:                                                                 | The annotation type identifier for container file citations.                       |
| `containerId`                                                                      | *string*                                                                           | :heavy_check_mark:                                                                 | The ID of the container (e.g., code interpreter container) where the file resides. |
| `endIndex`                                                                         | *number*                                                                           | :heavy_check_mark:                                                                 | The character index where the cited text ends in the output.                       |
| `fileId`                                                                           | *string*                                                                           | :heavy_check_mark:                                                                 | The ID of the file within the container being cited.                               |
| `filename`                                                                         | *string*                                                                           | :heavy_check_mark:                                                                 | The name of the file being cited.                                                  |
| `startIndex`                                                                       | *number*                                                                           | :heavy_check_mark:                                                                 | The character index where the cited text begins in the output.                     |