# AgentScheduleList

## Example Usage

```typescript
import { AgentScheduleList } from "@meetkai/mka1/models/components";

let value: AgentScheduleList = {
  object: "list",
  data: [],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: false,
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `object`                                                                                 | [components.AgentScheduleListObject](../../models/components/agentschedulelistobject.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `data`                                                                                   | [components.AgentSchedule](../../models/components/agentschedule.md)[]                   | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `firstId`                                                                                | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `lastId`                                                                                 | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `hasMore`                                                                                | *boolean*                                                                                | :heavy_check_mark:                                                                       | N/A                                                                                      |