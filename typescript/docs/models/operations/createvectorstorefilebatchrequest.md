# CreateVectorStoreFileBatchRequest

## Example Usage

```typescript
import { CreateVectorStoreFileBatchRequest } from "@meetkai/mka1/models/operations";

let value: CreateVectorStoreFileBatchRequest = {
  vectorStoreId: "vs_abc123",
  createVectorStoreFileBatchRequest: {
    fileIds: [
      "file-abc123",
      "file-def456",
      "file-ghi789",
    ],
    attributes: {
      "batch_id": "import-2024-01",
    },
  },
};
```

## Fields

| Field                                                                                                           | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     | Example                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `vectorStoreId`                                                                                                 | *string*                                                                                                        | :heavy_check_mark:                                                                                              | N/A                                                                                                             | vs_abc123                                                                                                       |
| `xOnBehalfOf`                                                                                                   | *string*                                                                                                        | :heavy_minus_sign:                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                             |                                                                                                                 |
| `createVectorStoreFileBatchRequest`                                                                             | [components.CreateVectorStoreFileBatchRequest](../../models/components/createvectorstorefilebatchrequest.md)    | :heavy_check_mark:                                                                                              | N/A                                                                                                             | {<br/>"file_ids": [<br/>"file-abc123",<br/>"file-def456",<br/>"file-ghi789"<br/>],<br/>"attributes": {<br/>"batch_id": "import-2024-01"<br/>}<br/>} |