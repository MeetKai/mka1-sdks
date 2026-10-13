# DeleteAgentScheduleResponseBody

Deletion result.

## Example Usage

```typescript
import { DeleteAgentScheduleResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteAgentScheduleResponseBody = {
  object: "agent.schedule.deleted",
  id: "<id>",
  deleted: true,
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `object`                                                                                     | [operations.DeleteAgentScheduleObject](../../models/operations/deleteagentscheduleobject.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `deleted`                                                                                    | *boolean*                                                                                    | :heavy_check_mark:                                                                           | N/A                                                                                          |