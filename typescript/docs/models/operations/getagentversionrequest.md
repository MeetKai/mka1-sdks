# GetAgentVersionRequest

## Example Usage

```typescript
import { GetAgentVersionRequest } from "@meetkai/mka1/models/operations";

let value: GetAgentVersionRequest = {
  agentId: "<id>",
  version: 326580,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |