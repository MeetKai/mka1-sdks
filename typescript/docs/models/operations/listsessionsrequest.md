# ListSessionsRequest

## Example Usage

```typescript
import { ListSessionsRequest } from "@meetkai/mka1/models/operations";

let value: ListSessionsRequest = {};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionKey`                                                        | *string*                                                            | :heavy_minus_sign:                                                  | Only sessions created with this session_key.                        |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |