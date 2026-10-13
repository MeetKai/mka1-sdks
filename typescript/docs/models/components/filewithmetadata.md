# FileWithMetadata

A file with optional per-file metadata and chunking strategy.

## Example Usage

```typescript
import { FileWithMetadata } from "@meetkai/mka1/models/components";

let value: FileWithMetadata = {
  fileId: "<id>",
};
```

## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `fileId`                                                | *string*                                                | :heavy_check_mark:                                      | A File ID that the vector store should use.             |
| `attributes`                                            | Record<string, *components.FileWithMetadataAttributes*> | :heavy_minus_sign:                                      | Optional attributes for this specific file.             |
| `chunkingStrategy`                                      | *components.FileWithMetadataChunkingStrategy*           | :heavy_minus_sign:                                      | Optional chunking strategy for this specific file.      |