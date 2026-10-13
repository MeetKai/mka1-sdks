# VectorStoreExpiresAfter

The expiration policy for a vector store.

## Example Usage

```typescript
import { VectorStoreExpiresAfter } from "@meetkai/mka1/models/components";

let value: VectorStoreExpiresAfter = {
  anchor: "last_active_at",
  days: 889626,
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `anchor`                                                                                               | *"last_active_at"*                                                                                     | :heavy_check_mark:                                                                                     | Anchor timestamp after which the expiration policy applies. Supported anchors: last_active_at.         |
| `days`                                                                                                 | *number*                                                                                               | :heavy_check_mark:                                                                                     | The number of days after the anchor time that the vector store will expire. Must be between 1 and 365. |