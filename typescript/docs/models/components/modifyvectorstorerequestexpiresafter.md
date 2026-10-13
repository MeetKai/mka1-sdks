# ModifyVectorStoreRequestExpiresAfter

The expiration policy for a vector store.

## Example Usage

```typescript
import { ModifyVectorStoreRequestExpiresAfter } from "@meetkai/mka1/models/components";

let value: ModifyVectorStoreRequestExpiresAfter = {
  anchor: "last_active_at",
  days: 523029,
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `anchor`                                                                                               | *"last_active_at"*                                                                                     | :heavy_check_mark:                                                                                     | Anchor timestamp after which the expiration policy applies. Supported anchors: last_active_at.         |
| `days`                                                                                                 | *number*                                                                                               | :heavy_check_mark:                                                                                     | The number of days after the anchor time that the vector store will expire. Must be between 1 and 365. |