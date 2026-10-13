# FileList

## Example Usage

```typescript
import { FileList } from "@meetkai/mka1/models/components";

let value: FileList = {
  object: "list",
  data: [
    {
      id: "file-abc123",
      bytes: 125000,
      createdAt: 1704067200,
      filename: "product-manual.pdf",
      purpose: "assistants",
      status: "processed",
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `object`                                               | *"list"*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `data`                                                 | [components.FileT](../../models/components/filet.md)[] | :heavy_check_mark:                                     | N/A                                                    |
| `firstId`                                              | *string*                                               | :heavy_minus_sign:                                     | N/A                                                    |
| `lastId`                                               | *string*                                               | :heavy_minus_sign:                                     | N/A                                                    |
| `hasMore`                                              | *boolean*                                              | :heavy_check_mark:                                     | N/A                                                    |