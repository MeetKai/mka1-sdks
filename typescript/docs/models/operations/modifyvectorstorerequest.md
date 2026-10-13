# ModifyVectorStoreRequest

## Example Usage

```typescript
import { ModifyVectorStoreRequest } from "@meetkai/mka1/models/operations";

let value: ModifyVectorStoreRequest = {
  vectorStoreId: "vs_abc123",
  modifyVectorStoreRequest: {
    name: "Updated Documentation Store",
    expiresAfter: {
      anchor: "last_active_at",
      days: 60,
    },
  },
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `vectorStoreId`                                                                                        | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | vs_abc123                                                                                              |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `modifyVectorStoreRequest`                                                                             | [components.ModifyVectorStoreRequest](../../models/components/modifyvectorstorerequest.md)             | :heavy_check_mark:                                                                                     | N/A                                                                                                    | {<br/>"name": "Updated Documentation Store",<br/>"expires_after": {<br/>"anchor": "last_active_at",<br/>"days": 60<br/>}<br/>} |