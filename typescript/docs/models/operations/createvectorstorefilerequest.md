# CreateVectorStoreFileRequest

## Example Usage

```typescript
import { CreateVectorStoreFileRequest } from "@meetkai/mka1/models/operations";

let value: CreateVectorStoreFileRequest = {
  vectorStoreId: "vs_abc123",
  createVectorStoreFileRequest: {
    fileId: "file-abc123",
    attributes: {
      "category": "manual",
      "version": "2.0",
    },
  },
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `vectorStoreId`                                                                                    | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | vs_abc123                                                                                          |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |
| `createVectorStoreFileRequest`                                                                     | [components.CreateVectorStoreFileRequest](../../models/components/createvectorstorefilerequest.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                | {<br/>"file_id": "file-abc123",<br/>"attributes": {<br/>"category": "manual",<br/>"version": "2.0"<br/>}<br/>} |