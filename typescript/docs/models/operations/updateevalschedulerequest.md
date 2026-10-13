# UpdateEvalScheduleRequest

## Example Usage

```typescript
import { UpdateEvalScheduleRequest } from "@meetkai/mka1/models/operations";

let value: UpdateEvalScheduleRequest = {
  scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  updateEvalScheduleRequest: {},
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `scheduleId`                                                                                 | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          | eval_sched_aa87e2b1112a455b8deabed784372198                                                  |
| `xOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |
| `updateEvalScheduleRequest`                                                                  | [components.UpdateEvalScheduleRequest](../../models/components/updateevalschedulerequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |                                                                                              |