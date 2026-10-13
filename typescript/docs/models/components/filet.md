# FileT

## Example Usage

```typescript
import { FileT } from "@meetkai/mka1/models/components";

let value: FileT = {
  id: "file-abc123",
  bytes: 125000,
  createdAt: 1704067200,
  filename: "product-manual.pdf",
  purpose: "assistants",
  status: "processed",
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `id`                                                           | *string*                                                       | :heavy_check_mark:                                             | The file identifier                                            |
| `object`                                                       | *"file"*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `bytes`                                                        | *number*                                                       | :heavy_check_mark:                                             | The size of the file in bytes                                  |
| `createdAt`                                                    | *number*                                                       | :heavy_check_mark:                                             | Unix timestamp when the file was created                       |
| `expiresAt`                                                    | *number*                                                       | :heavy_minus_sign:                                             | Unix timestamp when the file expires                           |
| `filename`                                                     | *string*                                                       | :heavy_check_mark:                                             | The name of the file                                           |
| `purpose`                                                      | [components.Purpose](../../models/components/purpose.md)       | :heavy_check_mark:                                             | The intended purpose of the file                               |
| `status`                                                       | [components.FileStatus](../../models/components/filestatus.md) | :heavy_minus_sign:                                             | DEPRECATED: File processing status                             |
| `statusDetails`                                                | *string*                                                       | :heavy_minus_sign:                                             | DEPRECATED: Details about file status                          |