# GetVectorStoreRequest

## Example Usage

```typescript
import { GetVectorStoreRequest } from "@meetkai/mka1/models/operations";

let value: GetVectorStoreRequest = {
  vectorStoreId: "vs_abc123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |