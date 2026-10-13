# GetVectorStoreFileContentRequest

## Example Usage

```typescript
import { GetVectorStoreFileContentRequest } from "@meetkai/mka1/models/operations";

let value: GetVectorStoreFileContentRequest = {
  vectorStoreId: "vs_abc123",
  fileId: "file-abc123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `fileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |