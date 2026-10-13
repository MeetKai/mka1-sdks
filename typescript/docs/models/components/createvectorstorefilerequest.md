# CreateVectorStoreFileRequest

Request body for creating a vector store file.

## Example Usage

```typescript
import { CreateVectorStoreFileRequest } from "@meetkai/mka1/models/components";

let value: CreateVectorStoreFileRequest = {
  fileId: "file-abc123",
  attributes: {
    "category": "manual",
    "version": "2.0",
  },
};
```

## Fields

| Field                                                                                                                                                                                                   | Type                                                                                                                                                                                                    | Required                                                                                                                                                                                                | Description                                                                                                                                                                                             |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `fileId`                                                                                                                                                                                                | *string*                                                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                                                      | A File ID that the vector store should use. Useful for tools like file_search that can access files.                                                                                                    |
| `attributes`                                                                                                                                                                                            | Record<string, *components.CreateVectorStoreFileRequestAttributes*>                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                      | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters, booleans, or numbers. |
| `chunkingStrategy`                                                                                                                                                                                      | *components.CreateVectorStoreFileRequestChunkingStrategy*                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                      | The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.                                                                                                                |