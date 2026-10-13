# StreamAgentRunEventsRequest

## Example Usage

```typescript
import { StreamAgentRunEventsRequest } from "@meetkai/mka1/models/operations";

let value: StreamAgentRunEventsRequest = {
  agentId: "<id>",
  runId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `runId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |