# GetAgentScheduleRequest

## Example Usage

```typescript
import { GetAgentScheduleRequest } from "@meetkai/mka1/models/operations";

let value: GetAgentScheduleRequest = {
  agentId: "<id>",
  scheduleId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `scheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |