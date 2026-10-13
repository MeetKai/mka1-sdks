# ListFeatureFlagAuditEntriesRequest

## Example Usage

```typescript
import { ListFeatureFlagAuditEntriesRequest } from "@meetkai/mka1/models/operations";

let value: ListFeatureFlagAuditEntriesRequest = {};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `limit`                                                             | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `before`                                                            | *number*                                                            | :heavy_minus_sign:                                                  | Return entries with an id lower than this (from next_before).       |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |