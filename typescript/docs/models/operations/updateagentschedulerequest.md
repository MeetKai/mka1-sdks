# UpdateAgentScheduleRequest

## Example Usage

```typescript
import { UpdateAgentScheduleRequest } from "@meetkai/mka1/models/operations";

let value: UpdateAgentScheduleRequest = {
  agentId: "<id>",
  scheduleId: "<id>",
  updateAgentScheduleRequest: {},
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `agentId`                                                                                      | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `scheduleId`                                                                                   | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `updateAgentScheduleRequest`                                                                   | [components.UpdateAgentScheduleRequest](../../models/components/updateagentschedulerequest.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |