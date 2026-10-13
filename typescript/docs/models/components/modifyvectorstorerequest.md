# ModifyVectorStoreRequest

Request body for modifying a vector store.

## Example Usage

```typescript
import { ModifyVectorStoreRequest } from "@meetkai/mka1/models/components";

let value: ModifyVectorStoreRequest = {
  name: "Updated Documentation Store",
  expiresAfter: {
    anchor: "last_active_at",
    days: 60,
  },
};
```

## Fields

| Field                                                                                                                                                                             | Type                                                                                                                                                                              | Required                                                                                                                                                                          | Description                                                                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                                                                                            | *string*                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                | The name of the vector store.                                                                                                                                                     |
| `expiresAfter`                                                                                                                                                                    | [components.ModifyVectorStoreRequestExpiresAfter](../../models/components/modifyvectorstorerequestexpiresafter.md)                                                                | :heavy_minus_sign:                                                                                                                                                                | The expiration policy for a vector store.                                                                                                                                         |
| `metadata`                                                                                                                                                                        | Record<string, *string*>                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters. |