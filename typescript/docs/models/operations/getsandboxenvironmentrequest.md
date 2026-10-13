# GetSandboxEnvironmentRequest

## Example Usage

```typescript
import { GetSandboxEnvironmentRequest } from "@meetkai/mka1/models/operations";

let value: GetSandboxEnvironmentRequest = {
  environmentId: 393766,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `environmentId`                                                     | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |