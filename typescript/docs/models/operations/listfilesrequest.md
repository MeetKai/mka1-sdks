# ListFilesRequest

## Example Usage

```typescript
import { ListFilesRequest } from "@meetkai/mka1/models/operations";

let value: ListFilesRequest = {
  after: "file-abc123",
  limit: 100,
  purpose: "assistants",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `after`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        | file-abc123                                                                                |
| `limit`                                                                                    | *number*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        | 100                                                                                        |
| `order`                                                                                    | [operations.ListFilesQueryParamOrder](../../models/operations/listfilesqueryparamorder.md) | :heavy_minus_sign:                                                                         | N/A                                                                                        | desc                                                                                       |
| `purpose`                                                                                  | [operations.QueryParamPurpose](../../models/operations/queryparampurpose.md)               | :heavy_minus_sign:                                                                         | N/A                                                                                        | assistants                                                                                 |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |