# RollbackAgentVersionRequest

## Example Usage

```typescript
import { RollbackAgentVersionRequest } from "@meetkai/mka1/models/operations";

let value: RollbackAgentVersionRequest = {
  agentId: "<id>",
  version: 909814,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |